using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;
using NUnit.Framework;

namespace University.UnitTests
{
    [TestFixture]
    public class StudentSponsoredUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var ulyana = CreateTestStudentSponsored();

            Assert.AreEqual("Ульяна", ulyana.Name);
            Assert.AreEqual("Советова", ulyana.Surname);
            Assert.AreEqual(3334, ulyana.Number);
            Assert.AreEqual("Everlasting Games", ulyana.Sponsor);
            Assert.AreEqual(550000, ulyana.Price);
        }

        [Test]
        public void ToStringTest()
        {
            var ulyana = CreateTestStudentSponsored();
            Assert.AreEqual("Ульяна Советова", ulyana.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var ulyana = CreateTestStudentSponsored();

            ulyana.Group = 116004;
            ulyana.Institute = "УГИ";
            ulyana.Type = StudyType.Bachelor;
            var info = ulyana.GetInfo();

            Assert.AreEqual(2, info.Length);
            Assert.AreEqual("Ульяна Советова", info[0]);
            Assert.AreEqual($"Номер зачётной книжки: 4443. Группа: 116004. Институт: УГИ. Направление обучения: бакалавриат.\nЦелевое предприятие: Everlasting Games. Стоимость обучения: 550000", info[1]);
        }

        private StudentSponsored CreateTestStudentSponsored()
        {
            return new StudentSponsored("Ульяна", "Советова", 3334, "Everlasting Games", 550000);
        }
    }
}
