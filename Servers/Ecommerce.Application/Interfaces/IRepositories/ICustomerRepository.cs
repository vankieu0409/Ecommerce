﻿using Ecommerce.Domain.Entities.Author;
using Ecommerce.Shared.Common.Repositories;

namespace Ecommerce.Application.Interfaces.IRepositories;

public interface ICustomerRepository : IRepositoryAsync<Customer>
{

}