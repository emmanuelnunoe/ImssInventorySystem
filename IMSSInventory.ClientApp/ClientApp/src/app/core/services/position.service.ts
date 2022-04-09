import { Injectable } from '@angular/core';
import { PositionModel } from '../models/position.model'
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry, map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class PositionService {

  configUrl = 'https://localhost:7070/api';
  constructor(private http: HttpClient) { }

  getPositions(): Observable<PositionModel[]> {
    const httpOptions = this.getHeaders();
    return this.http.get<PositionModel[]>(`${this.configUrl}/positions`,httpOptions);
  }

  saveNewPosition(newPositionModel: PositionModel): Observable<PositionModel> {
    const position = JSON.stringify(newPositionModel);
    const headers = this.getHeaders();
    return this.http.post<PositionModel>(this.configUrl + `/positions/add/`, position, headers);
  }

  deletePosition(positionId: number) {
    const httpOptions = this.getHeaders();
    return this.http.delete(this.configUrl + `/positions/delete?position=${positionId}`, httpOptions)
  }

  getHeaders() {
    const httpOptions = {
      headers: new HttpHeaders({
        'Access-Control-Allow-Origin': 'https://localhost:44451',
        'Content-Type': 'application/json',
      })
    };
    return httpOptions;
  }
}
