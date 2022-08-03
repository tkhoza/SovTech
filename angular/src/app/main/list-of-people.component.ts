import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { CategoriesServiceProxy, PeopleDto } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-list-of-people',
  templateUrl: './list-of-people.component.html',
  styleUrls: ['./list-of-people.component.css']
})
export class ListOfPeopleComponent extends AppComponentBase implements OnInit{

  constructor(
    injector: Injector, 
    public categoryAppService: CategoriesServiceProxy,
  ) {
    super(injector);
  }

  records: PeopleDto[] = [];
  filterText = "";
  isProcessing = false;

  ngOnInit(): void {
    this.getData();
  }

  getData(): void{
    this.isProcessing = true;
    this.categoryAppService.getPeople(this.filterText).subscribe((result) => {
      this.records = result.items;
      this.isProcessing = false;
    });
  }

}
