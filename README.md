# Courier Service – EverestEngineering Coding Challenge

This project calculates delivery cost and estimated delivery time for packages
based on offer codes, vehicle capacity, and routing rules.

## Architecture
- Domain layer contains core business entities (Package, Offer, Vehicle, Shipment)
- Core layer contains business logic (CostCalculator, OfferService, ShipmentPlanner, DeliveryScheduler)
- App is a CLI for input/output
- Tests validate pricing and offer rules

## How it works
1. Delivery cost is calculated using:
   BaseCost + (Weight * 10) + (Distance * 5)
2. Discounts are applied if the package matches the offer criteria
3. Packages are grouped into shipments based on:
   - Maximum number of packages
   - Maximum total weight
   - Shortest delivery distance
4. Vehicles deliver shipments and return before taking the next

## How to run
