﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagementProject.Models;

namespace LeaveManagementProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<LeaveManagementProject.Models.LeaveTypeVM> LeaveTypeVM { get; set; }
        public DbSet<LeaveManagementProject.Models.EmployeeVM> EmployeeVM { get; set; }
        public DbSet<LeaveManagementProject.Models.LeaveAllocationVM> LeaveAllocationVM { get; set; }
        public DbSet<LeaveManagementProject.Models.EditLeaveAllocationVM> EditLeaveAllocationVM { get; set; }
    }
}
