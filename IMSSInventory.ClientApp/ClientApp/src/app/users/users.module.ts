import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, Validators, FormControl, ValidationErrors, NgForm } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import PositionComponent from './position/position.component';
import { MatButton } from '@angular/material/button';
import { MatTable } from '@angular/material/table';
@NgModule({
  declarations: [
    PositionComponent
  ],
  imports: [
    MatTable,
    MatButton,
    CommonModule,
    FormsModule,
    FormControl,
    Validators,
    BrowserModule,
  ]
})
export class UsersModule { }
