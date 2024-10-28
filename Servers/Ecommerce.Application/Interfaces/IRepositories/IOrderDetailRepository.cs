﻿using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Shared.Common.Repositories;

namespace Ecommerce.Application.Interfaces.IRepositories;

public interface IOrderDetailRepository : IRepositoryAsync<OrderDetail>
{

}