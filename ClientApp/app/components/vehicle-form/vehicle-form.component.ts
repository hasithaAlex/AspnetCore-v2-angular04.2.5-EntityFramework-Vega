import { VehicleService } from './../../services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  models: any[];
  features: any = [];
  vehicle: any = {};

  constructor(
  private vehicleService: VehicleService) { }

  ngOnInit() {
    this.vehicleService.getMakes().
      subscribe(_makes => 
        {       
          this.makes = _makes;
        });

     this.vehicleService.getFeatures().subscribe(_features => this.features = _features)    
  }

  onMakeChanges(){
    var selectedMake = this.makes.find(m => m.id == this.vehicle.make);
    this.models = selectedMake ? selectedMake.models : [];
  }
}
