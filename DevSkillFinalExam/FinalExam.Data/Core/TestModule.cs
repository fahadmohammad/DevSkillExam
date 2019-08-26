using Autofac;
using FinalExam.Data.Core.Model;
using FinalExam.Data.Core.Services;
using FinalExam.Data.Core.UOW;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core
{
    public class TestModule : Module
    {
        private readonly string _conncectionString;
        private readonly string _migrationAssemblyName;

        public TestModule(IConfiguration configuration, string conncectionStringName, string migrationAssemblyName)
        {
            this._conncectionString = configuration.GetConnectionString(conncectionStringName);
            this._migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager<IdentityUser>>();
            builder.RegisterType<SignInManager<IdentityUser>>();

            builder.RegisterType<TestDbContext>()
                .WithParameter("connectionString", _conncectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentUnitOfwork>()
                .WithParameter("connectionString", _conncectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName);
            builder.RegisterType<CourseUnitOfWork>()
               .WithParameter("connectionString", _conncectionString)
               .WithParameter("migrationAssemblyName", _migrationAssemblyName);

            builder.RegisterType<StudentModel>();
            builder.RegisterType<StudentService>();

            builder.RegisterType<CourseModel>();
            builder.RegisterType<CourseService>();

            base.Load(builder);
        }
    }
}
