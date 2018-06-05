using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presidents.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presidents.Controllers
{


    [Route("api/[controller]")]
    public class PresidentController : Controller

    {

 
        //Presidents List
        IList<President> presidentList = new List<President>(){

            new President() { Name = "George Washington", Birthday = "1732-2-22" , Birthplace = "Westmoreland Co., Va.", Deathday = "1799-12-14", Deathplace = "Mount Vernon, Va." },

            new President() { Name = "John Adams", Birthday = "1735-10-30" , Birthplace = "Quincy, Mass.", Deathday = "1826-7-4", Deathplace = "Quincy, Mass." },

            new President() { Name = "Thomas Jefferson", Birthday = "1743-4-13" , Birthplace = "Albemarle Co., Va.", Deathday = "1826-7-4", Deathplace = "Albemarle Co., Va." },

            new President() { Name = "James Madison", Birthday = "1751-3-16" , Birthplace = "Port Conway, Va.", Deathday = "1836-6-28", Deathplace = "Orange Co., Va." },

            new President() { Name = "James Monroe", Birthday = "1758-4-28" , Birthplace = "Westmoreland Co., Va.", Deathday = "1831-7-4", Deathplace = "New York, New York" },

            new President() { Name = "John Quincy Adams", Birthday = "1767-7-11" , Birthplace = "Quincy, Mass.", Deathday = "1848-2-23", Deathplace = "Washington, D.C." },

            new President() { Name = "Andrew Jackson", Birthday = "1767-3-15" , Birthplace = "Waxhaws, No./So. Carolina", Deathday = "1845-6-8", Deathplace = "Nashville, Tennessee" },

            new President() { Name = "Martin Van Buren", Birthday = "1782-12-5" , Birthplace = "Kinderhook, New York", Deathday = "1862-7-24", Deathplace = "Kinderhook, New York" },

            new President() { Name = "William Henry Harrison", Birthday = "1773-2-9" , Birthplace = "Charles City Co., Va.", Deathday = "1841-4-4", Deathplace = "Washington, D.C." },

            new President() { Name = "John Tyler", Birthday = "1790-3-29" , Birthplace = "Charles City Co., Va.", Deathday = "1862-1-18", Deathplace = "Richmond, Va." },

            new President() { Name = "James K. Polk", Birthday = "1795-11-2" , Birthplace = "Mecklenburg Co., N.C.", Deathday = "1849-6-15", Deathplace = "Nashville, Tennessee" },

            new President() { Name = "Zachary Taylor", Birthday = "1784-11-24" , Birthplace = "Orange County, Va.", Deathday = "1850-7-9", Deathplace = "Washington, D.C" },

            new President() { Name = "Millard Fillmore", Birthday = "1800-1-7" , Birthplace = "Cayuga Co., New York", Deathday = "1874-3-8", Deathplace = "Buffalo, New York" },

            new President() { Name = "Franklin Pierce", Birthday = "1804-11-23" , Birthplace = "Hillsborough, N.H.", Deathday = "1869-10-8", Deathplace = "Concord, New Hamp." },

            new President() { Name = "James Buchanan", Birthday = "1791-4-23" , Birthplace = "Cove Gap, Pa.", Deathday = "1868-6-1", Deathplace = "Lancaster, Pa." },

            new President() { Name = "Abraham Lincoln", Birthday = "1809-2-12" , Birthplace = "LaRue Co., Kentucky", Deathday = "1865-4-15", Deathplace = "Washington, D.C." },

            new President() { Name = "Andrew Johnson", Birthday = "1808-12-29" , Birthplace = "Raleigh, North Carolina", Deathday = "1875-7-31", Deathplace = "Elizabethton, Tenn." },

            new President() { Name = "Ulysses S. Grant", Birthday = "1822-4-27" , Birthplace = "Point Pleasant, Ohio", Deathday = "1885-7-23", Deathplace = "Wilton, New York" },

            new President() { Name = "Rutherford B. Hayes", Birthday = "1822-10-4" , Birthplace = "Delaware, Ohio", Deathday = "1893-1-17", Deathplace = "Fremont, Ohio" },

            new President() { Name = "James A. Garfield", Birthday = "1831-11-19" , Birthplace = "Cuyahoga Co., Ohio", Deathday = "1881-9-19", Deathplace = "Elberon, New Jersey" },

            new President() { Name = "Chester Arthur", Birthday = "1829-10-5" , Birthplace = "Fairfield, Vermont", Deathday = "1886-11-18", Deathplace = "New York, New York" },

            new President() { Name = "Grover Cleveland", Birthday = "1837-3-18" , Birthplace = "Caldwell, New Jersey", Deathday = "1908-6-24", Deathplace = "Princeton, New Jersey" },

            new President() { Name = "Benjamin Harrison", Birthday = "1833-8-20" , Birthplace = "North Bend, Ohio", Deathday = "1901-3-13", Deathplace = "Indianapolis, Indiana" },

            new President() { Name = "William McKinley", Birthday = "1843-1-29" , Birthplace = "Niles, Ohio", Deathday = "1901-9-14", Deathplace = "Buffalo, New York" },

            new President() { Name = "Theodore Roosevelt", Birthday = "1858-10-27" , Birthplace = "New York, New York", Deathday = "1919-1-6", Deathplace = "Oyster Bay, New York" },

            new President() { Name = "William Howard Taft", Birthday = "1857-9-15" , Birthplace = "Cincinnati, Ohio", Deathday = "1930-3-8", Deathplace = "Washington, D.C." },

            new President() { Name = "Woodrow Wilson", Birthday = "1856-12-28" , Birthplace = "Staunton, Virginia", Deathday = "1924-2-3", Deathplace = "Washington, D.C." },

            new President() { Name = "Warren G. Harding", Birthday = "1865-11-2" , Birthplace = "Morrow County, Ohio", Deathday = "1923-8-2", Deathplace = "San Francisco, Cal." },

            new President() { Name = "Calvin Coolidge", Birthday = "1872-7-4" , Birthplace = "Plymouth, Vermont", Deathday = "1933-1-5", Deathplace = "Northampton, Mass." },

            new President() { Name = "Herbert Hoover", Birthday = "1874-8-10" , Birthplace = "West Branch, Iowa", Deathday = "1964-10-20", Deathplace = "New York, New York" },

            new President() { Name = "Franklin Roosevelt", Birthday = "1882-1-30" , Birthplace = "Hyde Park, New York", Deathday = "1945-4-12", Deathplace = "Warm Springs, Georgia" },

            new President() { Name = "Harry S. Truman", Birthday = "1884-5-8" , Birthplace = "Lamar, Missouri", Deathday = "1972-12-26", Deathplace = "Kansas City, Missouri" },

            new President() { Name = "Dwight Eisenhower", Birthday = "1890-10-14" , Birthplace = "Denison, Texas", Deathday = "1969-3-28", Deathplace = "Washington, D.C." },

            new President() { Name = "John F. Kennedy", Birthday = "1917-5-29" , Birthplace = "Brookline, Mass.", Deathday = "1963-11-22", Deathplace = "Dallas, Texas" },

            new President() { Name = "Lyndon B. Johnson", Birthday = "1908-8-27" , Birthplace = "Gillespie Co., Texas", Deathday = "1973-1-22", Deathplace = "Gillespie Co., Texas" },

            new President() { Name = "Richard Nixon", Birthday = "1913-1-9" , Birthplace = "Yorba Linda, Cal.", Deathday = "1994-4-22", Deathplace = "New York, New York" },

            new President() { Name = "Gerald Ford", Birthday = "1913-7-14" , Birthplace = "Omaha, Nebraska", Deathday = "2006-12-26", Deathplace = "Rancho Mirage, Cal." },

            new President() { Name = "Jimmy Carter", Birthday = "1924-10-1" , Birthplace = "Plains, Georgia", Deathday = "", Deathplace = "" },

            new President() { Name = "Ronald Reagan", Birthday = "1911-2-6" , Birthplace = "Tampico, Illinois", Deathday = "2004-6-5", Deathplace = "Los Angeles, Cal." },

            new President() { Name = "George Bush", Birthday = "1924-6-12" , Birthplace = "Milton, Mass.", Deathday = "", Deathplace = "" },

            new President() { Name = "Bill Clinton", Birthday = "1946-8-19" , Birthplace = "Hope, Arkansas", Deathday = "", Deathplace = "" },

            new President() { Name = "George W. Bush", Birthday = "1646-7-6" , Birthplace = "New Haven, Conn.", Deathday = "", Deathplace = "" },

            new President() { Name = "Barack Obama", Birthday = "1961-8-4" , Birthplace = "Honolulu, Hawaii", Deathday = "", Deathplace = "" },

            new President() { Name = "Donald Trump", Birthday = "1946-6-14" , Birthplace = "New York, New York", Deathday = "", Deathplace = "" }


            };


        [HttpGet("/api/presidents/Welcome", Name = "Welcome")]
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }



        // GET: api/values

        // All Names
        [HttpGet("/api/presidents/allNames", Name = "allNames")]
        public IList<President> AllPresidents()
        {
            return presidentList;
        }

        // Ascending Names
        [HttpGet("/api/presidents/namesAscending", Name = "namesAscending")]
        public IOrderedEnumerable<President> PresidentNameAscending()
        {
            return presidentList.OrderBy(value => value.Name);
        }

        // Descending Names
        [HttpGet("/api/presidents/namesDescending", Name = "namesDescending")]
        public IOrderedEnumerable<President> PresidentNameDescending()
        {
            return presidentList.OrderByDescending(value => value.Name);
        }
      


    } // End of class PresidentController


 


} // End of Namespace Presidents.Controllers
