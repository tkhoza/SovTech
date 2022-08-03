import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { CategoriesServiceProxy } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-chucks',
  templateUrl: './chucks.component.html',
  //styleUrls: ['./chucks.component.css']
})
export class ChucksComponent extends AppComponentBase implements OnInit{

  constructor(
    injector: Injector, public categoryAppService: CategoriesServiceProxy,
  ) {
    super(injector);
  }

  records: string[] = [];
  joke = '';
  isProcessing = false;

  ngOnInit(): void {
    this.joke = '';
    this.getData();
  }

  getData(): void{
    this.isProcessing = true;
    this.categoryAppService.getAllCategories().subscribe((result) => {
      this.records = result.items;
      this.joke = '';
      this.isProcessing = false;
    });
  }

  getCategoryDetails(category:string):void{
    this.isProcessing = true;
    this.categoryAppService.getAllCategoriesDetails(category).subscribe((result) => {
      this.joke = result;
      this.isProcessing = false;
    });
  }
  
}
