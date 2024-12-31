import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environment';
import { Observable } from 'rxjs';
import { MatchStatus } from '../../helpers/enums';

@Injectable({
  providedIn: 'root'
})
export class FixturesService {
private path = environment.apiUrl;

  constructor(private httpClient: HttpClient) { }

  getFixtures(filterDate: string): Observable<ListViewModel[]> {
    const params = new HttpParams().set('filterDate', filterDate);
    return this.httpClient.get<ListViewModel[]>(this.path + '/fixture', { params: params })
  }
}

export interface ListViewModel {
  isPinned: boolean;
  leagueId: number;
  countryName: string;
  leagueName: string;
  roundName: string;
  countryFlagUrl: string;
  items: ItemsViewModel[];
}

export interface ItemsViewModel {
  id: number;
  time: string;
  home: string;
  away: string;
  homeBrandUrl: string;
  awayBrandUrl: string;
  goals: GoalViewModel;
  fullTime: FullTimeViewModel;
  halfTime: HalfTimeViewModel;
  status: StatusViewModel;
}

export interface FullTimeViewModel {
  home: number | null;
  away: number | null;
}

export interface HalfTimeViewModel {
  home: number | null;
  away: number | null;
}

export interface StatusViewModel {
  matchStatus: MatchStatus;
  long: string;
  short: string;
  elapsed: number | null;
  extra: number | null;
}

export interface GoalViewModel {
  home: number | null;
  away: number | null;
}
