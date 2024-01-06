import { TestBed } from '@angular/core/testing';

import { ImobileService } from './imobile.service';

describe('ImobileService', () => {
  let service: ImobileService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ImobileService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
