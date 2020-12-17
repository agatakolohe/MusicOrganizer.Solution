using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
    [TestClass]
    public class ArtistTests : IDisposable
    {
        public void Dispose()
        {
            Artist.ClearAll();
        }

        [TestMethod]
        public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
        {
            Artist newArtist = new Artist("test");
            Assert.AreEqual(typeof(Artist), newArtist.GetType());
        }

        [TestMethod]
        public void GetArtistName_ReturnsArtistName_String()
        {
            string artistName = "Led Zeppelin";

            Artist newArtist = new Artist(artistName);
            string result = newArtist.ArtistName;

            Assert.AreEqual(artistName, result);
        }


        [TestMethod]
        public void GetAll_ReturnsEmptyList_ArtistList()
        {
            List<Artist> newArtistList = new List<Artist> { };

            List<Artist> result = Artist.GetAll();

            CollectionAssert.AreEqual(newArtistList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsArtists_ArtistList()
        {
            string newArtistName01 = "Led Zeppelin";
            string newArtistName02 = "ACDC";
            Artist newArtist01 = new Artist(newArtistName01);
            Artist newArtist02 = new Artist(newArtistName02);
            List<Artist> newArtistList = new List<Artist> { newArtist01, newArtist02 };

            List<Artist> result = Artist.GetAll();

            CollectionAssert.AreEqual(newArtistList, result);
        }

        [TestMethod]
        public void GetId_ReturnsArtistId_Int()
        {
            string newArtistName01 = "Led Zeppelin";
            Artist newArtist01 = new Artist(newArtistName01);

            int result = newArtist01.Id;

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectArtist_Artist()
        {
            string newArtistName01 = "Led Zeppelin";
            string newArtistName02 = "ACDC";
            Artist newArtist01 = new Artist(newArtistName01);
            Artist newArtist02 = new Artist(newArtistName02);

            Artist result = Artist.Find(2);

            Assert.AreEqual(newArtist02, result);
        }

    }
}