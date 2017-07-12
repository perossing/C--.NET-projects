using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMenu.Data
{
    public class PriceRepository
    {
        public static DTO.PriceDTO GetPrices()
        {
            var db = new PizzaMenu_dBEntities();
            var prices = db.PizzaPrices.First();
            var priceDTO = convertToDTO(prices);
            return priceDTO;
        }
            
        private static DTO.PriceDTO convertToDTO(PizzaPrice price)
        {
            var priceDTO = new DTO.PriceDTO();

            priceDTO.SmallSizeCost = price.SmallSizeCost;
            priceDTO.MediumSizeCost = price.MediumSizeCost;
            priceDTO.LargeSizeCost = price.LargeSizeCost;
            priceDTO.ThickCrustCost = price.ThickCrustCost;
            priceDTO.ThinCrustCost = price.ThinCrustCost;
            priceDTO.RegularCrustCost = price.RegularCrustCost;
            priceDTO.SausageCost = price.SausageCost;
            priceDTO.PepperoniCost = price.PepperoniCost;
            priceDTO.OnionsCost = price.OnionsCost;
            priceDTO.GreenPeppersCost = price.GreenPeppersCost;

            return priceDTO;
        }

    }
}
