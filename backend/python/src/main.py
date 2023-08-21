from fastapi import FastAPI
from src.web.orders.controllers import router as orders_router

app = FastAPI()


app.include_router(orders_router)
