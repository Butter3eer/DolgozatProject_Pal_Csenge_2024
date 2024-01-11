using DolgozatProject;

namespace TestDolgozatProject
{
    internal class JoTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void JoJolAdVisszaUresListanal()
        {
            Assert.That(dolgozat.Jo, Is.EqualTo(0));
        }

        [Test]
        public void JoJolAdVisszaEgyElemesListanalAmiNemJo()
        {
            dolgozat.Pontfelvesz(85);
            Assert.That(dolgozat.Jo, Is.EqualTo(0));
        }

        [Test]
        public void JoJolAdVisszaEgyElemesListanalAmiJo()
        {
            dolgozat.Pontfelvesz(75);
            Assert.That(dolgozat.Jo, Is.EqualTo(1));
        }

        [Test]
        public void JoJolAdVisszaEgyElemesListanalAmiJoAlsoHatarral()
        {
            dolgozat.Pontfelvesz(71);
            Assert.That(dolgozat.Jo, Is.EqualTo(1));
        }

        [Test]
        public void JoJolAdVisszaEgyElemesListanalAmiNemJoAlsoHatarAlatt()
        {
            dolgozat.Pontfelvesz(70);
            Assert.That(dolgozat.Jo, Is.EqualTo(0));
        }

        [Test]
        public void JoJolAdVisszaEgyElemesListanalAmiJoFlsoHatarral()
        {
            dolgozat.Pontfelvesz(80);
            Assert.That(dolgozat.Jo, Is.EqualTo(1));
        }

        [Test]
        public void JoJolAdVisszaEgyElemesListanalAmiNemJoFlsoHatarFelett()
        {
            dolgozat.Pontfelvesz(81);
            Assert.That(dolgozat.Jo, Is.EqualTo(0));
        }

        [Test]
        public void JoJolAdVisszaTobbElemesListanalAmiNemJo()
        {
            dolgozat.Pontfelvesz(100);
            dolgozat.Pontfelvesz(89);
            dolgozat.Pontfelvesz(34);
            Assert.That(dolgozat.Jo, Is.EqualTo(0));
        }

        [Test]
        public void JoJolAdVisszaTobbElemesListanalAmibenVanJo()
        {
            dolgozat.Pontfelvesz(75);
            dolgozat.Pontfelvesz(67);
            dolgozat.Pontfelvesz(34);
            Assert.That(dolgozat.Jo, Is.EqualTo(1));
        }

        [Test]
        public void JoJolAdVisszaTobbElemesListanalAmiJo()
        {
            dolgozat.Pontfelvesz(72);
            dolgozat.Pontfelvesz(73);
            dolgozat.Pontfelvesz(74);
            Assert.That(dolgozat.Jo, Is.EqualTo(3));
        }

        [Test]
        public void JoJolAdVisszaTobbElemesListanalAmibenVanJoAlsoHatarral()
        {
            dolgozat.Pontfelvesz(71);
            dolgozat.Pontfelvesz(61);
            dolgozat.Pontfelvesz(49);
            Assert.That(dolgozat.Jo, Is.EqualTo(1));
        }

        [Test]
        public void JoJolAdVisszaTobbElemesListanalAmibenVanJoFelsoHatarral()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(60);
            dolgozat.Pontfelvesz(70);
            Assert.That(dolgozat.Jo, Is.EqualTo(1));
        }
    }
}
