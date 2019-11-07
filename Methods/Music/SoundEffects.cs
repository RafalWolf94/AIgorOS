using System;
using System.Collections.Generic;
using System.IO;
using System.Media;

namespace AIgorOS.Methods.Music
{
    public class SoundEffects
    {
        private List<Stream> streams = new List<Stream>();
        private SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Menu);
        public enum TrackName
        {
            MENU = 0,
            O_MACIEJ = 1,
            ALERT = 2,
            ALERT1 = 3,
            ALERT2 = 4,
            C = 5,
            CE = 6,
            JEDEN = 7,
            DWA = 8,
            TRZY = 9,
            CZTERY = 10,
            PIEC = 11,
            SZCZESC = 12,
            SIEDEM = 13,
            OSIEM = 14,
            DZIEWIEC = 15,
            PLUS = 16,
            MINUS = 17,
            RAZY = 18,
            PODZIELIC = 19,
            DOPOTEGI = 20,
            PROCENT = 21,
            SUMA = 22,
            PIERWIASTEK = 23,
            PRZECINEK = 24,
            ZERO = 25,
            EXIT = 26,
            KALKULATOR = 27,
            GRATULACJE = 28,
            GRA = 29,
            NOTATNIK = 30,
            WITAJ = 31,
            WIDZENIA = 32,
            TICTACTOE = 33,
            CARRACE = 34,       
        }
        public SoundEffects()
        {
            streams.Add(Properties.Resources.Menu);
            streams.Add(Properties.Resources.O_Maciej);
            streams.Add(Properties.Resources.Alert);
            streams.Add(Properties.Resources.Alert1);
            streams.Add(Properties.Resources.Alert2);
            streams.Add(Properties.Resources.C);
            streams.Add(Properties.Resources.CE);
            streams.Add(Properties.Resources.Jeden);
            streams.Add(Properties.Resources.Dwa);
            streams.Add(Properties.Resources.Trzy);
            streams.Add(Properties.Resources.Cztery);
            streams.Add(Properties.Resources.Piec);
            streams.Add(Properties.Resources.Szesc);
            streams.Add(Properties.Resources.Siedem);
            streams.Add(Properties.Resources.Osiem);
            streams.Add(Properties.Resources.Dziewiec);
            streams.Add(Properties.Resources.plus);
            streams.Add(Properties.Resources.Minus);
            streams.Add(Properties.Resources.razy);
            streams.Add(Properties.Resources.Podzielic);
            streams.Add(Properties.Resources.DoPotegi);
            streams.Add(Properties.Resources.Procent);
            streams.Add(Properties.Resources.suma);
            streams.Add(Properties.Resources.Pierwiastek);
            streams.Add(Properties.Resources.Przecinek);
            streams.Add(Properties.Resources.Zero);
            streams.Add(Properties.Resources.Exit);
            streams.Add(Properties.Resources.Kalkulator);
            streams.Add(Properties.Resources.Gratulacje);
            streams.Add(Properties.Resources.Gra);
            streams.Add(Properties.Resources.Notatnik);
            streams.Add(Properties.Resources.Witaj);
            streams.Add(Properties.Resources.Widzenia);
            streams.Add(Properties.Resources.TicTacToe);
            streams.Add(Properties.Resources.CarRace);         

        }

        public void Play(TrackName name)
        {
            Play((uint)name);
        }
        public void Play(uint track_id)
        {
            if (track_id >= streams.Count || streams[(int)track_id] == null)
                throw new ArgumentException("sory boi");

            soundPlayer.Stream = streams[(int)track_id];
            soundPlayer.Stream.Position = 0;
            soundPlayer.Play();
        }
        public void PlayLoop(TrackName name)
        {
            Play((uint)name);
        }
        public void PlayLoop(uint track_id)
        {
            if (track_id >= streams.Count || streams[(int)track_id] == null)
                throw new ArgumentException("sory boi");

            soundPlayer.Stream = streams[(int)track_id];
            soundPlayer.Stream.Position = 0;
            soundPlayer.PlayLooping();
        }
        




    }
}
