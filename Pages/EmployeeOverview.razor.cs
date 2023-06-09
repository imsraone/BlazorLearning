﻿using BethanysPieShopHRM.Shared.Domain;
using BlazorLearning.Models;

namespace BlazorLearning.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default;

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }
    }
}
