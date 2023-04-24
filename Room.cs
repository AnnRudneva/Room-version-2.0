using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    namespace RoomLibrary
{
    public class Room
    {
        double roomLenght;//длина комнаты
        double roomWidth;//ширина комнаты
        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimetr()
        {
            return 2 * (roomLenght + roomWidth);
        }
        /// <summary>
        ///Метод вычисляет площадь комнаты 
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomAreas()
        {
            return roomLenght * roomWidth;
        }
        /// <summary>
        /// Метод вычисляет число квадратных метров
        /// нв одного человека
        /// </summary>
        /// <param name="np">Число человек </param>
        /// <returns>Возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomAreas() / np;
        }
    }

}