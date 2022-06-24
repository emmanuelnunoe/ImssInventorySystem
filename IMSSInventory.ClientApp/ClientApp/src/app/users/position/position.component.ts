import { Component} from '@angular/core';

@Component({
  selector: 'app-position',
  templateUrl: './position.component.html',
  styleUrls: ['./position.component.css']
})
export default class PositionComponent  {

  constructor() {

  }


  //public deletePosition(positionId: number) {
  //  this.positionProvider.deletePosition(positionId).subscribe({
  //    complete: () => {
  //      console.log("Se ha eliminado correctamente la posicion");
  //      this.ngOnInit();
  //    },
  //    error: (error: any) => {
  //      console.log(`Error al intentar eliminar la posicion ${error.message}`)
  //    }
  //  })
  //}

  //public getPositions() {
  //  this.positionProvider.getPositions().subscribe((result: PositionModel[]) => {
  //    this.positions = result;
  //    console.log(this.positions);
  //  }), (err: any) => {
  //    console.log(err); 
  //  } ;
  //}

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
