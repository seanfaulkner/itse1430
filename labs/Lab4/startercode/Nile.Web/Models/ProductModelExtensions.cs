using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nile.Web.Models
{
    public static class ProductModelExtensions
    {
        /// <summary>Converts a model to a movie.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The movie.</returns>
        public static Product ToDomain ( this ProductModel source )
        {
            if (source == null)
                return null;

            return new Product () {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.IsDiscontinued
            };
        }

        /// <summary>Converts a movie to a model.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The model.</returns>
        public static ProductModel ToModel ( this Product source )
        {
            if (source == null)
                return null;

            return new ProductModel () {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.IsDiscontinued
            };
        }
    }

}