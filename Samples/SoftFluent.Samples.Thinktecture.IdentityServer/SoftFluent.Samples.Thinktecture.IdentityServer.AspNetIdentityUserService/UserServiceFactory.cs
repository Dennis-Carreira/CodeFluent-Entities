/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SoftFluent.Samples.Thinktecture.IdentityServer;
using SoftFluent.Samples.Thinktecture.IdentityServer.Web.Security;
using Thinktecture.IdentityServer.Core.Services;

namespace Thinktecture.IdentityServer.AspNetIdentity
{
    public class UserServiceFactory
    {
        static UserServiceFactory()
        {
            //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.CreateDatabaseIfNotExists<IdentityDbContext>());
            //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.CreateDatabaseIfNotExists<CustomDbContext>());
        }
        
        public static IUserService Factory()
        {
           //CodeFluent Entities
            var store = new UserStore();
            var mgr = new UserManager<User>(store);
            var userSvc = new UserService<User, string>(mgr, null);
            return userSvc;

            //var db = new IdentityDbContext<IdentityUser>("DefaultConnection");
            //var store = new UserStore<IdentityUser>(db);
            //var mgr = new UserManager<IdentityUser>(store);
            //var userSvc = new UserService<IdentityUser, string>(mgr, db);
            //return userSvc;

            //var db = new CustomDbContext("CustomAspId");
            //var store = new CustomUserStore(db);
            //var mgr = new CustomUserManager(store);
            //var userSvc = new UserService<CustomUser, int>(mgr, db);
            //return userSvc;
        }
    }
}
