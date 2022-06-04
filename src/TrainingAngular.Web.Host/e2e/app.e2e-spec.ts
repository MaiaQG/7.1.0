import { TrainingAngularTemplatePage } from './app.po';

describe('TrainingAngular App', function() {
  let page: TrainingAngularTemplatePage;

  beforeEach(() => {
    page = new TrainingAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
