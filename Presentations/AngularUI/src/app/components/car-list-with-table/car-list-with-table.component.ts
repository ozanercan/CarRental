import { Component, OnInit } from '@angular/core';
import { CarDetailDto } from 'src/app/models/Dtos/carDetailDto';
import { CarService } from 'src/app/services/car.service';
import { TitleService } from 'src/app/services/title.service';

@Component({
  selector: 'app-car-list-with-table',
  templateUrl: './car-list-with-table.component.html',
  styleUrls: ['./car-list-with-table.component.css'],
})
export class CarListWithTableComponent implements OnInit {
  constructor(
    private carService: CarService,
    private titleService: TitleService
  ) {
    this.getCarDetails();
  }

  ngOnInit(): void {
    this.titleService.setTitle('Araçlar');
  }

  carDetails: CarDetailDto[] = [];
  filterText: string = '';
  getCarDetails() {
    this.carService.getCarDetails().subscribe((response) => {
      this.carDetails = response.data;
    });
  }
}
