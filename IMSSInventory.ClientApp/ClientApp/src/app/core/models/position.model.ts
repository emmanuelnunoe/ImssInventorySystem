export interface PositionModel {
  id: number | undefined;
  positionName: string | undefined;
}

export class PositionModel {

  constructor(id: number, name: string) {
    return new PositionModel(
      this.id = id,
       this.positionName = name
    );
  }
}
