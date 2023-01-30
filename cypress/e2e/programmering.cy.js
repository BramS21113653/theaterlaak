// import dayjs from 'dayjs';

describe("programmering page", () => {
  it("the fetched items include ...", () => {
    cy.visit("https://localhost:44474/programmering")  
    cy.get("div").eq(0).contains((/\d{4}-\d{2}-\d{2}\w{1}\d{2}\:\d{2}\:\d{2}/))
  })
})