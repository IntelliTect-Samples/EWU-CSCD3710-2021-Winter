using System;
using System.IO;
using System.Collections.Generic;

namespace Assignment
{
    public class SampleData : ISampleData
    {

        public SampleData()
        {
            string path = "C:/Users/overl/Desktop/people.csv";
            CsvRows = System.IO.File.ReadAllLines(path);
            List<Person> peopleList = new List<Person>();
            foreach (string csvRow in CsvRows)
            {
                string[] fields = csvRow.Split(',');
                for (int i = 0; i < 8; i++)
                {
                    Address address = new Address(fields[4], fields[5], fields[6], fields[7]);
                    peopleList.Add(new Person(fields[1],fields[2],address,fields[3]));
                }
            }
            People = peopleList.ToArray();
        }
        // 1.
        public IEnumerable<string> CsvRows { get; }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows() 
            => throw new NotImplementedException();

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => throw new NotImplementedException();

        // 4.
        public IEnumerable<IPerson> People { get; }

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
    }
}
