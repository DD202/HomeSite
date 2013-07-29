using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomDeMaioHomePage.Models
{
    public class Resume
    {
        #region Constructor
        public Resume()
        {
            Person = new Person();
            ProfessionalExperience = new ProfessionalExperience();
            Education = new Education();
        }
        #endregion

        #region Public Accessors
        public Person Person { get; set; }
        public ProfessionalExperience ProfessionalExperience { get; set; }
        public Education Education { get; set; }
        #endregion

    }

    public class Person
    {
        #region Constructor
        public Person()
        {
            Address = new Address();
            PhoneNumbers = new List<PhoneNumber>();
        }
        #endregion

        #region Public Accessors
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMailAddress { get; set; }
        public Address Address { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; } 
        #endregion
    }

    public class Address
    {
        #region Constructor
        public Address()
        {

        }
        #endregion
        #region Public Accessors
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; } 
        #endregion
    }

    public class PhoneNumber
    {
        public string Type { get; set; }
        public string Number { get; set; }
    }

    public class ProfessionalExperience
    {
        #region Constructor
        public ProfessionalExperience()
        {
            Jobs = new List<Job>();
            Skills = new List<Skill>();
            Trainings = new List<Training>();
            Awards = new List<Award>();
        }
        #endregion
        #region Public Accessors
        public List<Job> Jobs { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Training> Trainings { get; set; }
        public List<Award> Awards { get; set; } 
        #endregion
    }

    public class Job
    {
        #region Constructor
        public Job()
        {
            Address = new Address();
            Contributions = new List<Contribution>();
        }
        #endregion

        #region Public Accessors
        public string Title { get; set; }
        public Address Address { get; set; }
        public string Company { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<Contribution> Contributions { get; set; } 
        #endregion
    }

    public class Contribution
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Benefit { get; set; }
    }

    public class Skill
    {
        public string Type { get; set; }
        public string Description { get; set; }
    }
    public class Training
    {
        public string Vendor { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Award
    {
        public string Description { get; set; }
    }

    public class Education
    {
        #region Constructor
        public Education()
        {
            Colleges = new List<College>();
        }
        #endregion
        #region Public Accessors
        public List<College> Colleges { get; set; }
        #endregion
        
    }

    public class College
    {
        public string Name { get; set; }
        public DateTime? GraduationDate { get; set; }
        public string Degree { get; set; }
        public string Major { get; set; }
        public string Minor { get; set; }
        public decimal? MajorGpa { get; set; }
        public decimal? CumulativeGpa { get; set; }
    }
}