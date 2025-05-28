using CarRentalApp.Core.Entities;
using CarRentalApp.Core.InterfacesRepository;
using CarRentalApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Infrastructure.Repositories
{
    public class ReservationRepository: IReservationRepository
    {
        private readonly ApplicationDbContext _context;

        public ReservationRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddReservationAsync(Reservation reservation)
        {
            if (reservation.StartDate >=reservation.EndDate)
            {
                throw new ArgumentException("Start date must be before end date.");
            }

            try
            {
                await _context.Reservations.AddAsync(reservation);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding reservation.", ex);
            }
        }

        public async Task DeleteReservationAsync(int reservationId)
        {
            try
            {
                var reservation = _context.Reservations.Find(reservationId);

                if (reservation!=null)
                {
                    _context.Reservations.Remove(reservation);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting reservation.", ex);
            }
        }

        public async Task<Reservation> GetReservationByIdAsync(int reservationId)
        {
            try
            {
                var reservation = await _context.Reservations.FindAsync(reservationId);

                return reservation == null ? throw new KeyNotFoundException($"Reservation with ID {reservationId} not found.") : reservation;
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching reservation by ID.", ex);
            }
        }

        public Task<List<Reservation>> GetReservationsByUserIdAsync(int userId)
        {
            try
            {
                return _context.Reservations
                    .Where(r => r.UserId == userId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching reservations by user ID.", ex);
            }
        }

        public async Task UpdateReservationAsync(Reservation reservation)
        {
            try
            {
                var existingReservation = await _context.Reservations.FindAsync(reservation.Id);

                if (existingReservation == null)
                {
                    throw new KeyNotFoundException($"Reservation with ID {reservation.Id} not found.");
                }

                existingReservation.CarId = reservation.CarId;
                existingReservation.UserId = reservation.UserId;
                existingReservation.StartDate = reservation.StartDate;
                existingReservation.EndDate = reservation.EndDate;
                existingReservation.TotalCost = reservation.TotalCost;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating reservation.", ex);
            }
        }
    }
}
