using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// In Base ad id Prodotto restitutisco un ogetto corrispondente a tale id
        /// </summary>
        /// <param name="productId">Parametro di filtro per prodotto</param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if(productId == 1)
            {
                product.CurrentPrice = 0;
                product.ProductDescription = "A product";
                product.ProductName = "Nutella";
            }

            return product;
        }

        /// <summary>
        /// Salva un oggetto in memoria
        /// </summary>
        /// <param name="product">oggetto popolato, parametro</param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            return true;
        }
    }
}
