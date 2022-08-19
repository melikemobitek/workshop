using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class StoreSeed : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {


            builder.HasData(
                new Store { Id = 1, Name = "Kalemler" },
                new Store { Id = 2, Name = "Kitaplar" },
                new Store { Id = 3, Name = "Defterler" });
        }
    }
}
