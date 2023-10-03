
namespace B2B_API.Migrations
{
    using B2B_API.Providers.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AuthContext context)
        {
            if (context.Clients.Count() > 0)
            {
                return;
            }

            context.Clients.AddRange(BuildClientsList());
            context.SaveChanges();
        }

        private static List<Client> BuildClientsList()
        {

            List<Client> ClientsList = new List<Client> 
            {
                new Client
                { Id = AuthenticationType.APPUser, 
                    Secret= Helper.GetHash("pngsoft@2018"), 
                    Name="Web Menber User APP", 
                    ApplicationType =  ApplicationTypes.JavaScript, 
                    Active = true, 
                    RefreshTokenLifeTime = 7200, 
                    AllowedOrigin = "*"
                },
                new Client
                { Id = AuthenticationType.APPUserKey, 
                    Secret=Helper.GetHash("key@user"), 
                    Name="App user remote with key", 
                    ApplicationType =ApplicationTypes.JavaScript, 
                    Active = true, 
                    RefreshTokenLifeTime = 7200, 
                    AllowedOrigin = "*"
                },
                new Client
                { Id = AuthenticationType.APPUser,
                    Secret= Helper.GetHash("pngsoft@2019"),
                    Name="Travel Helper",
                    ApplicationType =  ApplicationTypes.JavaScript,
                    Active = true,
                    RefreshTokenLifeTime = 7200,
                    AllowedOrigin = "*"
                },
            };

            return ClientsList;
        }
    }
}