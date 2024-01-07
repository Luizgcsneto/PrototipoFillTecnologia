import { Address } from "./Address";

export class Imobile  {
  id: number;
  title: string;
  district: string;
  numberRooms: number;
  businessType: number;
  price: number;
  address: Address;


  constructor() {
    this.address = new Address()
  }
}
