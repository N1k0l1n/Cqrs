﻿using Cqrs.Models;
using MediatR;

namespace Cqrs.Data.Command
{
    public sealed class CreateEmployeeCommand : IRequest<Employee>
    {
        public CreateEmployeeCommand(string name, string address, string email, string phone)
        {
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;

        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
