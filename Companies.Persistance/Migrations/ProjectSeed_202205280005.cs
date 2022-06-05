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
                    ProjectName = "Localization API",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "Data Transfer",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "Management System",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 3
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "Jobs Board",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 4
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "Social Media",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 4
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "Offer Board",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });

            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "Platform for exchange currency",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 2
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "External data exchanger",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 2
                });

            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "Music Maker",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 3
                });
            Insert.IntoTable("Projects")
                .Row(new
                {
                    ProjectName = "Order food platform",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
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
                    ProjectName = "Localization API",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "Data Transfer",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "Management System",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 3
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "Jobs Board",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 4
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "Social Media",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 4
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "Offer Board",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 1
                });

            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "Platform for exchange currency",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 2
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "External data exchanger",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 2
                });

            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "Music Maker",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 3
                });
            Delete.FromTable("Projects")
                .Row(new
                {
                    ProjectName = "Order food platform",
                    ProjectDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, metus id laoreet ultrices, mi purus venenatis magna," +
                    " tempor efficitur purus est eu sapien. Nam ullamcorper iaculis urna ut dictum. Nam elementum molestie tristique. " +
                    "Morbi porta feugiat sollicitudin. Maecenas facilisis sapien vitae nisi venenatis, eget posuere mi semper. " +
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus nec quam leo.",
                    CompanyId = 5
                });
        }
    }
}
