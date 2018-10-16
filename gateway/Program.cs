﻿using System;

namespace startup
{
    class Program
    {
        public const string Env_Fabric_NodeIPOrFQDN = "Fabric_NodeIPOrFQDN";
        public const string Env_GatewayMode = "GatewayMode";
        public const string Env_Fabric_Endpoint_GatewayProxyResolverEndpoint = "Fabric_Endpoint_GatewayProxyResolverEndpoint";
        public const string Env_Gateway_Resolver_Uses_Dynamic_Port = "Gateway_Resolver_Uses_Dynamic_Port";

        public const string GatewayProxyResolverStaticPort = "19079";
        public const string LocalProxyResolverURI = "tcp://127.0.0.1:5000";

        public const string DiscoveryType_Static = "static";
        public const string DiscoveryType_LogicalDns = "logical_dns";

        static string GetDiscoveryType()
        {
            var fabricNodeIpOrFQDN = Environment.GetEnvironmentVariable(Env_Fabric_NodeIPOrFQDN);
            Console.WriteLine("Environment variable {0} = {1}", Env_Fabric_NodeIPOrFQDN, fabricNodeIpOrFQDN);
            var hostNameType = Uri.CheckHostName(fabricNodeIpOrFQDN);
            switch (hostNameType)
            {
                case UriHostNameType.IPv4:
                case UriHostNameType.IPv6:
                    return DiscoveryType_Static;

                case UriHostNameType.Dns:
                    return DiscoveryType_LogicalDns;

                default:
                    return String.Empty;
            }
        }

        static string GetResolverURI()
        {
            var fabricNodeIpOrFQDN = Environment.GetEnvironmentVariable(Env_Fabric_NodeIPOrFQDN);
            var gatewayMode = Environment.GetEnvironmentVariable(Env_GatewayMode);
            var proxyResolverEndpointPort = Environment.GetEnvironmentVariable(Env_Fabric_Endpoint_GatewayProxyResolverEndpoint);
            var isDynamicPortResolver = Environment.GetEnvironmentVariable(Env_Gateway_Resolver_Uses_Dynamic_Port);


            Console.WriteLine("Environment variable {0} = {1}", Env_Fabric_NodeIPOrFQDN, fabricNodeIpOrFQDN);
            Console.WriteLine("Environment variable {0} = {1}", Env_Fabric_Endpoint_GatewayProxyResolverEndpoint, proxyResolverEndpointPort);
            Console.WriteLine("Environment variable {0} = {1}", Env_GatewayMode, gatewayMode);
            Console.WriteLine("Environment variable {0} = {1}", Env_Gateway_Resolver_Uses_Dynamic_Port, isDynamicPortResolver);

            if (!Convert.ToBoolean(gatewayMode))
            {
                Console.WriteLine("Proxy not running in GatewayMode. Use local resolver {0}", LocalProxyResolverURI);
                return LocalProxyResolverURI;
            }

            if (!Convert.ToBoolean(isDynamicPortResolver))
            {
                proxyResolverEndpointPort = GatewayProxyResolverStaticPort;
            }

            string resolverURI = String.Format("tcp://{0}:{1}", fabricNodeIpOrFQDN, proxyResolverEndpointPort);
            return resolverURI;
        }

        static void ReplaceContents(string inputFile, string outputFile)
        {
            var fileContents = System.IO.File.ReadAllText(inputFile);

            string discoveryType = GetDiscoveryType();
            string resolverUri = GetResolverURI();

            Console.WriteLine("discovery type: {0}, resolver URI: {1}", discoveryType, resolverUri);
            fileContents = fileContents.Replace("DISCOVERYTYPE", discoveryType);
            fileContents = fileContents.Replace("RESOLVERURI", resolverUri);

            System.IO.File.WriteAllText(outputFile, fileContents);
        }

        static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("syntax: UpdateConfig.exe confile_template_file output_config_file");
                return 0;
            }

            Program.ReplaceContents(args[0], args[1]);
            return 1;
        }
    }
}