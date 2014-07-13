using System;
using System.Collections.Generic;

namespace FitNesseExamples.Fixtures
{
    public class EmployeesHiredBefore
    {
        public DateTime Date { get; set; }

        public EmployeesHiredBefore(DateTime date)
        {
            Date = date;
        }

        public List<Object> Query()
        {
            return  new List<object>
            {
                new List<object>
                {
                    new List<object>{"employee number", 1429},
                    new List<object>{"first name", "Bob"},
                    new List<object>{"last name", "Martin"},
                    new List<object>{"hire date", "10-Oct-1974"},
                },
                new List<object>
                {
                    new List<object>{"employee number", 8832},
                    new List<object>{"first name", "James"},
                    new List<object>{"last name", "Grenning"},
                    new List<object>{"hire date", "15-Dec-1979"},
                }
            };
        }
    }
}