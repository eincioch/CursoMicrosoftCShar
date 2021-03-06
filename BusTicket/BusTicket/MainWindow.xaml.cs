﻿using BusTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BusTicket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Reserva Reserva { get; set; }
        public List<Rutas> Rutas { get; set; }
        public List<Rutas> Resultados { get; set; }
        public List<Localizacion> Estaciones { get; set; }
        

        public MainWindow()
        {
            Estaciones = new List<Localizacion>()
            {
                new Localizacion() {
                    Ciudad = "Lima",
                    Estacion = "Lima Central",
                    Estado = "Lima",
                    Pais = "Peru",
                },
                new Localizacion() {
                    Ciudad = "Trujillo",
                    Estacion = "trujillo Central",
                    Estado = "Trujillo",
                    Pais = "Peru",
                }
            };

            Reserva = new Reserva()
            {
                Destino = Estaciones[0],
                Salida = Estaciones[1],
                Fecha = DateTime.Now,
            };

            Rutas = new List<Models.Rutas>()
            {
                new Rutas(){
                    Chofer  = "XY",
                    Compania  = "M",
                    Estaciones = Estaciones,
                    FechaInicio = DateTime.Now.AddDays(2),
                    FechaFin= DateTime.Now ,
                    Id = Guid.NewGuid()
                },
                new Rutas(){
                    Chofer  = "XX",
                    Compania  = "L",
                    Estaciones = Estaciones,
                    FechaInicio = DateTime.Now.AddDays(10),
                    FechaFin= DateTime.Now.AddDays(12) ,
                    Id = Guid.NewGuid()
                }

            };

            InitializeComponent();

            this.Origen.ItemsSource = Estaciones;
            this.Origen.SelectedItem = Reserva.Salida;
            this.Destino.ItemsSource = Estaciones;
            this.Destino.SelectedItem = Reserva.Destino;
            this.Fecha.SelectedDate = Reserva.Fecha;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BuscarViaje(Reserva);
        }

        public void BuscarViaje(Reserva reserva) {
            //modo explicito
            /*var query = from ruta in Rutas
                        where ruta.Estaciones.Contains(reserva.Destino) &&
                                ruta.Estaciones.Contains(reserva.Salida) &&
                                ruta.FechaInicio >= reserva.Fecha
                        select ruta;*/
            //modo implicito
            var query = Rutas.Where(g => true).Select(g => g);

            Resultados = query.ToList();
            LVResultados.ItemsSource = Resultados;
        }
    }
}
