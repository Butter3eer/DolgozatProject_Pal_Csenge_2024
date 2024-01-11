using DolgozatProject;

namespace TestDolgozatProject
{
    internal class ErvenytelenTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void ErvenytelenJolAdVisszaErteketUresListanal()
        {
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(false));
        }

        [Test]
        public void ErvenytelenJolAdVisszaErteketEgyElemesListanalHamis()
        {
            dolgozat.Pontfelvesz(65);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(false));
        }

        [Test]
        public void ErvenytelenJolAdVisszaErteketEgyElemesListanalIgaz()
        {
            dolgozat.Pontfelvesz(-1);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(true));
        }

        [Test]
        public void ErvenytelenJolAdVisszaErteketTobbElemesListanalHamis()
        {
            dolgozat.Pontfelvesz(65);
            dolgozat.Pontfelvesz(23);
            dolgozat.Pontfelvesz(1);
            dolgozat.Pontfelvesz(89);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(false));
        }

        [Test]
        public void ErvenytelenJolAdVisszaErteketTobbElemesListanalIgaz()
        {
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(23);
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(89);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(true));
        }

        [Test]
        public void ErvenytelenJolAdVisszaErteketTobbElemesListanalHamisVanAkiNemIrt()
        {
            dolgozat.Pontfelvesz(65);
            dolgozat.Pontfelvesz(23);
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(89);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(false));
        }

        [Test]
        public void ErvenytelenJolAdVisszaErteketTobbElemesListanalCsakIgaz()
        {
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(-1);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(true));
        }
    }
}
