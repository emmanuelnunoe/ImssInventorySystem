import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PositionService } from '../core/services/position.service';
import { PositionModel } from '../core/models/position.model';



@NgModule({
  declarations: [
    PositionService,
    PositionModel
  ],
  imports: [
    CommonModule
  ]
})
export class CoreModule { }
