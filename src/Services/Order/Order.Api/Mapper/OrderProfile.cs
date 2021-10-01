using AutoMapper;
using Order.Application.Features.Orders.Commands.CheckoutOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Api.Mapper
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            //CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
