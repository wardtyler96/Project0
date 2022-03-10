using System;

namespace EmployeeManagement {
    class Employee {
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermanent { get; set; }

        public double getBonus(double percent) {
            return empSalary*.05;
        }

        public virtual string WhoIam() {
            return "I am Parent Class";
        }
    }
}