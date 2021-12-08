 
            services.AddSingleton<IConnectionSettingsValues, ConnectionSettings>(p =>
            {
                return new ConnectionSettings(new Uri("http://localhost:9200"));
                 .BasicAuthentication("elasticUserName", "elasticPassword")
                .ServerCertificateValidationCallback((sender, cert, chain, errors) => true);
            });
            services.AddScoped<IElasticClient, ElasticClient>();
