import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PositionModel } from '../models/position.model';
import { PositionService } from "../services/position.service"
@Injectable({
  providedIn: 'root'
})

export class PositionProvider {

  constructor(private positionService: PositionService) {

  }

  getPositions(): Observable<PositionModel[]>{
    return this.positionService.getPositions();
  }

  saveNewPosition(newPosition:PositionModel): Observable<PositionModel> {
    return this.positionService.saveNewPosition(newPosition);
  }
  deletePosition(positionId: number): Observable<any>{
    return this.positionService.deletePosition(positionId);
  }
}
