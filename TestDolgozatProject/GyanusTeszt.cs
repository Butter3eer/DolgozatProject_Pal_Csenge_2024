using DolgozatProject;

namespace TestDolgozatProject
{
    internal class GyanusTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void GyanusErrortDobRosszErteknel()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { dolgozat.Gyanus(-5); });
        }

        [Test]
        public void GyanusJotAdVisszaUresListanal()
        {
            Assert.That(dolgozat.Gyanus(0), Is.EqualTo(false));
        }

        [Test]
        public void GyanusJotAdVisszaEgyElemesListanalHamis()
        {
            dolgozat.Pontfelvesz(85);
            Assert.That(dolgozat.Gyanus(1), Is.EqualTo(false));
        }

        [Test]
        public void GyanusJotAdVisszaEgyElemesListanalIgaz()
        {
            dolgozat.Pontfelvesz(85);
            Assert.That(dolgozat.Gyanus(0), Is.EqualTo(true));
        }

        [Test]
        public void GyanusJotAdVisszaTobbElemesListanalHamis()
        {
            dolgozat.Pontfelvesz(85);
            dolgozat.Pontfelvesz(44);
            dolgozat.Pontfelvesz(2);
            dolgozat.Pontfelvesz(35);
            dolgozat.Pontfelvesz(1);
            Assert.That(dolgozat.Gyanus(1), Is.EqualTo(false));
        }

        [Test]
        public void GyanusJotAdVisszaTobbElemesListanalIgaz()
        {
            dolgozat.Pontfelvesz(85);
            dolgozat.Pontfelvesz(44);
            dolgozat.Pontfelvesz(100);
            dolgozat.Pontfelvesz(35);
            dolgozat.Pontfelvesz(1);
            Assert.That(dolgozat.Gyanus(0), Is.EqualTo(true));
        }

        [Test]
        public void GyanusJotAdVisszaTobbElemesListanalHamisVanAkiNemIrtaMeg()
        {
            dolgozat.Pontfelvesz(85);
            dolgozat.Pontfelvesz(44);
            dolgozat.Pontfelvesz(2);
            dolgozat.Pontfelvesz(35);
            dolgozat.Pontfelvesz(-1);
            Assert.That(dolgozat.Gyanus(1), Is.EqualTo(false));
        }

        [Test]
        public void GyanusJotAdVisszaTobbElemesListanalIgazVanAkiNemIrtaMeg()
        {
            dolgozat.Pontfelvesz(85);
            dolgozat.Pontfelvesz(44);
            dolgozat.Pontfelvesz(100);
            dolgozat.Pontfelvesz(35);
            dolgozat.Pontfelvesz(-1);
            Assert.That(dolgozat.Gyanus(0), Is.EqualTo(true));
        }
    }
}
