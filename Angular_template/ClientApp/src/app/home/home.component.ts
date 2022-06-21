import { Component, Inject  } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public itemsdetails: ItemDetails[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ItemDetails[]>(baseUrl + 'ItemDetails').subscribe(result => {
      this.itemsdetails = result;
    }, error => console.error(error));
  }
}

interface ItemDetails {
  itemCode: string;
  saleCount: number;
}
