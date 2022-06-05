using Companies.Domain.Entities;
using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Migrations
{
    [Migration(202205280002)]
    public class CompanyDetailsSeed_202205280002 : Migration
    {
        public override void Down()
        {
            Delete.FromTable("CompanyDetails")
           .Row(new
           {
                CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
               "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
               " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
               " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
               CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
               "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
               " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
               " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
               CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
               "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
               "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
               "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
               "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
               CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
               "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
               "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
               "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
                CompanyId = 1
           });

            Delete.FromTable("CompanyDetails")
            .Row(new
            {
                 CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
                "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
                " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
                " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
                CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
                "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
                " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
                " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
                CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
                "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
                "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
                "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
                "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
                CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
                "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
                "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
                "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
                CompanyId = 2
            });

            Delete.FromTable("CompanyDetails")
           .Row(new
           {
                CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
               "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
               " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
               " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
               CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
               "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
               " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
               " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
               CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
               "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
               "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
               "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
               "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
               CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
               "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
               "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
               "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
               CompanyId = 3
           });

            Delete.FromTable("CompanyDetails")
           .Row(new
           {
                CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
               "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
               " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
               " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
               CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
               "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
               " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
               " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
               CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
               "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
               "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
               "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
               "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
               CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
               "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
               "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
               "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
               CompanyId = 4
           });

            Delete.FromTable("CompanyDetails")
           .Row(new
           {
                CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
               "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
               " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
               " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
               CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
               "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
               " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
               " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
               CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
               "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
               "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
               "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
               "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
               CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
               "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
               "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
               "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
               CompanyId = 5
           });
        }

        public override void Up()
        {
            Insert.IntoTable("CompanyDetails")
           .Row(new
           {
                CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
               "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
               " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
               " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
               CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
               "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
               " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
               " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
               CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
               "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
               "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
               "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
               "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
               CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
               "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
               "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
               "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
               CompanyId = 1
           });

            Insert.IntoTable("CompanyDetails")
            .Row(new
            {
                CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
                "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
                " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
                " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
                CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
                "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
                " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
                " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
                CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
                "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
                "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
                "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
                "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
                CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
                "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
                "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
                "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
                CompanyId = 2
            });

            Insert.IntoTable("CompanyDetails")
           .Row(new
           {
               CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
               "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
               " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
               " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
               CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
               "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
               " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
               " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
               CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
               "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
               "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
               "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
               "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
               CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
               "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
               "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
               "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
               CompanyId = 3
           });

            Insert.IntoTable("CompanyDetails")
           .Row(new
           {
               CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
               "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
               " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
               " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
               CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
               "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
               " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
               " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
               CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
               "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
               "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
               "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
               "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
               CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
               "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
               "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
               "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
               CompanyId = 4
           });

            Insert.IntoTable("CompanyDetails")
           .Row(new
           {
               CompanyDetailsDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed nec ex ante. " +
               "Duis dignissim est eu leo condimentum cursus.Aliquam nec quam id augue fringilla iaculis quis at turpis." +
               " Nam et sapien eget nibh semper mollis.Cras tincidunt sollicitudin enim, in porta enim interdum non." +
               " Praesent euismod mi ut augue interdum varius.Mauris posuere porttitor leo id tempor. Duis fringilla ex eu odio ultricies condimentum",
               CompanyDetailsHistory = "Mauris at ex in ex ullamcorper tincidunt quis quis justo. Donec lacinia augue vitae volutpat dignissim. " +
               "Fusce cursus faucibus bibendum. In hac habitasse platea dictumst.Fusce tempor pellentesque neque, sed pharetra purus accumsan vel." +
               " In efficitur ligula eget risus commodo bibendum.Morbi auctor quam felis. Pellentesque sagittis nisi ligula, ac mattis tellus pretium et." +
               " Donec faucibus metus eget metus dictum, id volutpat sapien rhoncus.Duis ac turpis vitae lacus tristique tincidunt.",
               CompanyDetailsOffer = "Ut facilisis nec arcu nec venenatis. In rutrum lacinia dui in dictum.Ut tempor maximus risus, at varius orci rhoncus non. " +
               "Nullam malesuada volutpat urna, eu faucibus nisl molestie ut. Orci varius natoque penatibus et magnis dis parturient montes, " +
               "nascetur ridiculus mus.Vivamus sollicitudin aliquet ex id fringilla. In sodales placerat dui ac hendrerit. Etiam massa sem, " +
               "rutrum non dolor ut, ultricies lacinia lorem. Proin elit enim, volutpat ut congue et, varius id lectus. Donec urna nibh, " +
               "placerat a nisl eu, posuere mattis felis. In at ornare libero, et fermentum ex. Aliquam vitae consectetur lectus. Phasellus ut pulvinar magna.",
               CompanyDetailsInformation = "Aenean mattis magna eu felis semper, eu congue mauris vehicula.Cras pellentesque eros eget lacus iaculis, " +
               "at elementum eros eleifend.Morbi placerat elit eget lacus facilisis, quis malesuada metus tincidunt.Sed pulvinar, " +
               "risus malesuada interdum pellentesque, ligula tellus bibendum leo, sed ultricies augue metus id lorem.Nunc rutrum magna at mollis tincidunt. " +
               "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi at metus lorem. Duis venenatis gravida mattis.",
               CompanyId = 5
           });
        }
    }
}
