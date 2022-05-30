using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Migrations
{
    [Migration(202205280005)]
    public class ProjectSeed_202205280005 : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Localization API",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Data Transfer",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Management System",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 3
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Jobs Board",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 4
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Social Media",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 4
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Offer Board",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });

            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Platform for exchange currency",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 2
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "External data exchanger",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 2
                });

            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Music Maker",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 3
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    Name = "Order food platform",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 5
                });
        }

        public override void Down()
        {
            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Localization API",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Data Transfer",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Management System",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 3
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Jobs Board",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 4
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Social Media",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 4
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Offer Board",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });

            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Platform for exchange currency",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 2
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "External data exchanger",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 2
                });

            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Music Maker",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 3
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    Name = "Order food platform",
                    Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 5
                });
        }
    }
}
