﻿using CleanArchictecture_2025.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture_2025.WebAPI;

public static class ExtensionsMiddleware
{
    public static void CreateFirstUser(WebApplication app)
    {
        using (var scoped = app.Services.CreateScope())
        {
            var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

            if (!userManager.Users.Any(p => p.UserName == "admin"))
            {
                AppUser user = new()
                {
                    UserName = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Salih",
                    LastName = "YILDIZ",
                    EmailConfirmed = true,
                    CreateAt = DateTimeOffset.Now,
                };

                user.CreateUserId = user.Id;

                userManager.CreateAsync(user, "Aa123456").Wait();


            }
        }
    }


}
