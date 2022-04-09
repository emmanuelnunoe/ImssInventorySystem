import { Position } from '@angular/compiler';
import { Component, OnChanges, OnInit, SimpleChanges, ViewChild } from '@angular/core';
import { FormControl, NgForm, ValidationErrors, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { pipe } from 'rxjs';
import { tap } from 'rxjs/operators';
import { PositionModel } from '../../core/models/position.model';
import { PositionProvider } from "../../core/providers/position.provider";

@Component({
  selector: 'app-position',
  templateUrl: './position.component.html',
  styleUrls: ['./position.component.css']
})
export default class PositionComponent implements OnInit, OnChanges {

  public positions: PositionModel[] = [];
  public errorMessage: string = "";
  public displayedColumns: string[] = ['id', 'positionName'];
  public position: PositionModel = new PositionModel(0,"");
  constructor(private positionProvider: PositionProvider, private _router: Router) {

  }
    ngOnChanges(changes: SimpleChanges): void {
        throw new Error('Method not implemented.');
    }

  ngOnInit(): void {
    this.getPositions();
    this.position.id = undefined;
    this.position.positionName = "";

  }

  public deletePosition(positionId: number) {
    this.positionProvider.deletePosition(positionId).subscribe({
      complete: () => {
        console.log("Se ha eliminado correctamente la posicion");
        this.ngOnInit();
      },
      error: (error: any) => {
        console.log(`Error al intentar eliminar la posicion ${error.message}`)
      }
    })
  }

  public getPositions() {
    this.positionProvider.getPositions().subscribe((result: PositionModel[]) => {
      this.positions = result;
      console.log(this.positions);
    }), (err: any) => {
      console.log(err); 
    } ;
  }

  //public savePosition(): void {
  //  console.log("creando nueva posicion..." + this.position);
  //  if (this.position != "" && this.position != undefined) {
  //    this.newPosition.PositionName = this.position;
  //    this.positionProvider.saveNewPosition(this.newPosition).subscribe({
  //      next: data => { console.log(data.PositionId) },
  //      error: error => {
  //        this.errorMessage = error.message;
  //        console.log('There was an error', error)
  //      }
  //    });
  //  }
  //}
}
