using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
    [TestClass]
    public class AlbumTests : IDisposable
    {
        public void Dispose()
        {
            Album.ClearAll();
        }

        [TestMethod]
        public void AlbumConstructor_CreateInstanceOfAlbum_Album()
        {
            Album newAlbum = new Album("test album");
            Assert.AreEqual(typeof(Album), newAlbum.GetType());
        }
        [TestMethod]
        public void GetAlbumName_ReturnAlbumName_String()
        {
            string albumName = "albumName";
            Album newAlbum = new Album(albumName);

            string result = newAlbum.AlbumName;

            Assert.AreEqual(albumName, result);
        }
        [TestMethod]
        public void GetId_ReturnsAlbumId_Int()
        {
            String albumName = "Test Alubm";
            Album newAlbum = new Album(albumName);
            int result = newAlbum.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]

        public void GetAll_ReturnAllAlbums_AlbumList()
        {
            string albumName01 = "back in black";
            string albumName02 = "houses of holy";
            string albumName03 = "houses of holy";
            Album newAlbum03 = new Album(albumName03);
            Album newAlbum01 = new Album(albumName01);
            Album newAlbum02 = new Album(albumName02);
            List<Album> newList = new List<Album> { newAlbum01, newAlbum02 };

            List<Album> result = Album.GetAll();

            CollectionAssert.AreEqual(newList, result);

        }

    }
}