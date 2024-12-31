import { Component, inject } from '@angular/core';
import { MaterialModule } from '../material/material.module';
import { MatSnackBar } from '@angular/material/snack-bar';
import { FixturesService, ListViewModel, ItemsViewModel } from '../services/fixtures/fixtures.service';
import { format } from "date-fns";
import { NgFor } from '@angular/common';
import { CommonModule } from '@angular/common';
import { MatchStatus } from '../helpers/enums';

@Component({
  selector: 'app-mainpage',
  imports: [ MaterialModule, NgFor, CommonModule ],
  templateUrl: './mainpage.component.html',
  styleUrl: './mainpage.component.css'
})
export class MainpageComponent {
  private _snackBar = inject(MatSnackBar);
  fixtures: ListViewModel[] = [];

  constructor(private fixtureService: FixturesService){
  }

  ngOnInit() {
    this.getFixtures();
  }
  
  matchInProgress(item: ItemsViewModel): boolean {
    console.log(item.status.matchStatus == MatchStatus.FirstHalf || item.status.matchStatus == MatchStatus.SecondHalf);
    return item.status.matchStatus == MatchStatus.FirstHalf || item.status.matchStatus == MatchStatus.SecondHalf;
  }

  getFixtures()
  {
    const currentDate = new Date();
    const dateFormat = format(currentDate, 'yyyy.MM.dd') 

    this.fixtureService.getFixtures(dateFormat).subscribe({
      next: (res: ListViewModel[]) => {
        this.fixtures = res;
      },
      error: err => {
        this._snackBar.open("Error 500", 'Exit');
      }
    })
  }
}
