using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMenu.Domain
{
    public class PriceManager
    {
        public static decimal CalculateCost(DTO.OrderDTO order)
        {
            decimal cost = 0.0M; // M needed to hardcode decimal variable
            var prices = getPrices(order);
            cost += calcSizeCost(order, prices);
            cost += calcCrustCost(order, prices);
            cost += calcToppingsCost(order, prices);
            return cost;
        }

        private static decimal calcSizeCost(DTO.OrderDTO order, DTO.PriceDTO prices)
        {
            decimal cost = 0.0M;
            switch (order.Size)
            {
                case PizzaMenu.DTO.Enums.SizeType.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case PizzaMenu.DTO.Enums.SizeType.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case PizzaMenu.DTO.Enums.SizeType.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static decimal calcCrustCost(DTO.OrderDTO order, DTO.PriceDTO prices)
        {
            decimal cost = 0.0M;
            switch (order.Crust)
            {
                case PizzaMenu.DTO.Enums.CrustType.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case PizzaMenu.DTO.Enums.CrustType.Thin:
                    cost = prices.ThinCrustCost;
                    break;
                case PizzaMenu.DTO.Enums.CrustType.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static decimal calcToppingsCost(DTO.OrderDTO order, DTO.PriceDTO prices)
        {
            decimal cost = 0.0M;
            cost += (order.Sausage) ? prices.SausageCost : 0M;
            cost += (order.Pepperoni) ? prices.PepperoniCost : 0M;
            cost += (order.Onions) ? prices.OnionsCost : 0M;
            cost += (order.GreenPeppers) ? prices.GreenPeppersCost : 0M;
            return cost;
        }

        public static DTO.PriceDTO getPrices(DTO.OrderDTO order)
        {
            var prices = Data.PriceRepository.GetPrices();
            return prices;
        }

    }
}
