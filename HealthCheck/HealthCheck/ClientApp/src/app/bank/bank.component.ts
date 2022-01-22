import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-bank',
  templateUrl: './bank.component.html'
})
export class BankComponent {
  public bankData: BankData;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<BankData>(baseUrl + 'bank').subscribe(result => {
      this.bankData = result;
    }, error => console.error(error));
  }
}

interface BankData {
  accountNumber: string;
  name: string;
}
