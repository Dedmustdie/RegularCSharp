using System;
using Xunit;
using Task;
using System.Text.RegularExpressions;
namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TimeSearchTest1()
        {
            string s = "Завтрак в 09:00";
            Assert.Equal(s.TimeSearch()[0].Value, "09:00");
        }
        [Fact]
        public void TimeSearchTest2()
        {
            string s = "37:98";
            Assert.Equal(s.TimeSearch().Count, 0);
        }
        [Fact]
        public void TimeSearchTest3()
        {
            string s = "24:00";
            Assert.Equal(s.TimeSearch().Count, 0);
        }
        [Fact]
        public void MacSearchTest1()
        {
            string s = "2141wefw 2124 21 aE:dC:cA:56:76:54 wfwe ";
            Assert.Equal(s.MacSearch()[0].Value, "aE:dC:cA:56:76:54");
        }
        [Fact]
        public void MacSearchTest2()
        {
            string s = "01:23:45:67:89:Az";
            Assert.Equal(s.MacSearch().Count, 0);
        }
        [Fact]
        public void EmailValidTest1()
        {
            string s = "user@example.com";
            Assert.Equal(s.EmailValid(), true);
        }
        [Fact]
        public void EmailValidTest2()
        {
            string s = "root@localhost";
            Assert.Equal(s.EmailValid(), true);
        }
        [Fact]
        public void EmailValidTest3()
        {
            string s = "bug@@@com.ru";
            Assert.Equal(s.EmailValid(), false);
        }
        [Fact]
        public void EmailValidTest4()
        {
            string s = "@val.ru";
            Assert.Equal(s.EmailValid(), false);
        }
        [Fact]
        public void EmailValidTest5()
        {
            string s = "Just Text2";
            Assert.Equal(s.EmailValid(), false);
        }
        [Fact]
        public void PasswordSafeTest1()
        {
            string s = "C00l_Pass";
            Assert.Equal(s.PasswordSafe(), true);
        }
        [Fact]
        public void PasswordSafeTest2()
        {
            string s = "SupperPas1";
            Assert.Equal(s.PasswordSafe(), true);
        }
        [Fact]
        public void PasswordSafeTest3()
        {
            string s = "Cool_pass";
            Assert.Equal(s.PasswordSafe(), false);
        }
        [Fact]
        public void PasswordSafeTest4()
        {
            string s = "C00l";
            Assert.Equal(s.PasswordSafe(), false);
        }
    }
}
