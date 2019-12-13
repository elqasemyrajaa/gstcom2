import { TestBed } from '@angular/core/testing';

import { StautService } from './staut.service';

describe('StautService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: StautService = TestBed.get(StautService);
    expect(service).toBeTruthy();
  });
});
