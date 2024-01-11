using DolgozatProject;

namespace TestDolgozatProject
{
    internal class KoezepesTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void KozepesJolAdVisszaUresListanal()
        {
            Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
        }

        [Test]
        public void KozepesJolAdVisszaEgyElemesListanalAmiNemKozepes()
        {
            dolgozat.Pontfelvesz(80);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
        }

        [Test]
        public void KozepesJolAdVisszaEgyElemesListanalAmiKozepes()
        {
            dolgozat.Pontfelvesz(67);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
        }

        [Test]
        public void KozepesJolAdVisszaEgyElemesListanalAmiKozepesAlsoHatarral()
        {
            dolgozat.Pontfelvesz(61);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
        }

        [Test]
        public void KozepesJolAdVisszaEgyElemesListanalAmiNemKozepesAlsoHatarAlatt()
        {
            dolgozat.Pontfelvesz(60);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
        }

        [Test]
        public void KozepesJolAdVisszaEgyElemesListanalAmiKozepesFlsoHatarral()
        {
            dolgozat.Pontfelvesz(70);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
        }

        [Test]
        public void KozepesJolAdVisszaEgyElemesListanalAmiNemKozepesFlsoHatarFelett()
        {
            dolgozat.Pontfelvesz(71);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
        }

        [Test]
        public void KozepesJolAdVisszaTobbElemesListanalAmiNemKozepes()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(89);
            dolgozat.Pontfelvesz(34);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
        }

        [Test]
        public void KozepesJolAdVisszaTobbElemesListanalAmibenVanKozepes()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(67);
            dolgozat.Pontfelvesz(34);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
        }

        [Test]
        public void KozepesJolAdVisszaTobbElemesListanalAmiKozepes()
        {
            dolgozat.Pontfelvesz(62);
            dolgozat.Pontfelvesz(63);
            dolgozat.Pontfelvesz(64);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(3));
        }

        [Test]
        public void KozepesJolAdVisszaTobbElemesListanalAmibenVanKozepesAlsoHatarral()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(61);
            dolgozat.Pontfelvesz(49);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
        }

        [Test]
        public void KozepesJolAdVisszaTobbElemesListanalAmibenVanKozepesFelsoHatarral()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(60);
            dolgozat.Pontfelvesz(70);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
        }
    }
}
