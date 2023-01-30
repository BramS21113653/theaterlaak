describe("home page", () => {
  it("the h1 contains the correct text", () => {
    cy.visit("https://localhost:44474")
    cy.get("h1").eq(0).contains("over ons")
    cy.get("h1").eq(1).contains("programmering")
  })
})